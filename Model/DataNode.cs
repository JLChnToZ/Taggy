﻿using Substrate.Nbt;
using System.Collections.Generic;

namespace Taggy.Model
{
    public class DataNode
    {
        private DataNode _parent;
        private DataNodeCollection _children;

        private bool _expanded;

        private bool _dataModified;
        private bool _childModified;

        public DataNode ()
        {
            _children = new DataNodeCollection(this);
        }

        public DataNode Parent
        {
            get { return _parent; }
            internal set { _parent = value; }
        }

        public DataNodeCollection Nodes
        {
            get { return _children; }
        }

        public bool IsModified
        {
            get { return _dataModified || _childModified; }
        }

        protected bool IsDataModified
        {
            get { return _dataModified; }
            set
            {
                _dataModified = value;
                CalculateChildModifiedState();
            }
        }

        protected bool IsChildModified
        {
            get { return _childModified; }
            set
            {
                _childModified = value;
                CalculateChildModifiedState();                
            }
        }

        protected bool IsParentModified
        {
            get { return Parent != null && Parent.IsModified; }
            set
            {
                if (Parent != null)
                    Parent.IsDataModified = value;
            }
        }

        private void CalculateChildModifiedState ()
        {
            _childModified = false;
            foreach (DataNode child in Nodes)
                if (child.IsModified)
                    _childModified = true;

            if (Parent != null)
                Parent.CalculateChildModifiedState();
        }

        public bool IsExpanded
        {
            get { return _expanded; }
            private set { _expanded = value; }
        }

        public void Expand ()
        {
            if (!IsExpanded) {
                ExpandCore();
                IsExpanded = true;
            }
        }

        protected virtual void ExpandCore () { }

        public void Collapse ()
        {
            if (IsExpanded && !IsModified) {
                Release();
                IsExpanded = false;
            }
        }

        public void Release ()
        {
            foreach (DataNode node in Nodes)
                node.Release();

            ReleaseCore();
            IsExpanded = false;
            IsDataModified = false;
        }

        protected virtual void ReleaseCore ()
        {
            Nodes.Clear();
        }

        public void Save ()
        {
            foreach (DataNode node in Nodes)
                if (node.IsModified)
                    node.Save();

            SaveCore();
            IsDataModified = false;
        }

        protected virtual void SaveCore ()
        {
        }

        public virtual string NodeName
        {
            get { return ""; }
        }

        public virtual string NodeDisplay
        {
            get { return ""; }
        }

        public virtual bool HasUnexpandedChildren
        {
            get { return false; }
        }

        protected Dictionary<string, object> BuildExpandSet (DataNode node)
        {
            if (node == null || !node.IsExpanded)
                return null;

            Dictionary<string, object> dict = new Dictionary<string, object>();
            foreach (DataNode child in node.Nodes) {
                Dictionary<string, object> childDict = BuildExpandSet(child);
                if (childDict != null)
                    dict[child.NodeDisplay] = childDict;
            }

            return dict;
        }

        protected void RestoreExpandSet (DataNode node, Dictionary<string, object> expandSet)
        {
            node.Expand();

            foreach (DataNode child in node.Nodes) {
                if (expandSet.ContainsKey(child.NodeDisplay)) {
                    Dictionary<string, object> childDict = (Dictionary<string, object>)expandSet[child.NodeDisplay];
                    if (childDict != null)
                        RestoreExpandSet(child, childDict);
                }
            }
        }

        #region Node Capabilities

        protected virtual NodeCapabilities Capabilities
        {
            get { return NodeCapabilities.None; }
        }

        public virtual bool CanRenameNode
        {
            get { return (Capabilities & NodeCapabilities.Rename) != NodeCapabilities.None; }
        }

        public virtual bool CanEditNode
        {
            get { return (Capabilities & NodeCapabilities.Edit) != NodeCapabilities.None; }
        }

        public virtual bool CanDeleteNode
        {
            get { return (Capabilities & NodeCapabilities.Delete) != NodeCapabilities.None; }
        }

        public virtual bool CanCopyNode
        {
            get { return (Capabilities & NodeCapabilities.Copy) != NodeCapabilities.None; }
        }

        public virtual bool CanCutNode
        {
            get { return (Capabilities & NodeCapabilities.Cut) != NodeCapabilities.None; }
        }

        public virtual bool CanPasteIntoNode
        {
            get { return (Capabilities & NodeCapabilities.PasteInto) != NodeCapabilities.None; }
        }

        public virtual bool CanSearchNode
        {
            get { return (Capabilities & NodeCapabilities.Search) != NodeCapabilities.None; }
        }

        public virtual bool CanReoderNode
        {
            get { return (Capabilities & NodeCapabilities.Reorder) != NodeCapabilities.None; }
        }

        public virtual bool CanRefreshNode
        {
            get { return (Capabilities & NodeCapabilities.Refresh) != NodeCapabilities.None; }
        }

        public virtual bool CanMoveNodeUp
        {
            get { return false; }
        }

        public virtual bool CanMoveNodeDown
        {
            get { return false; }
        }

        public virtual bool CanCreateTag (TagType type)
        {
            return false;
        }

        #endregion

        #region Group Capabilities

        public virtual GroupCapabilities RenameNodeCapabilities
        {
            get { return GroupCapabilities.Single; }
        }

        public virtual GroupCapabilities EditNodeCapabilities
        {
            get { return GroupCapabilities.Single; }
        }

        public virtual GroupCapabilities DeleteNodeCapabilities
        {
            get { return GroupCapabilities.MultiMixedType | GroupCapabilities.ElideChildren; }
        }

        public virtual GroupCapabilities CutNodeCapabilities
        {
            get { return GroupCapabilities.Single; } //SiblingMixedType
        }

        public virtual GroupCapabilities CopyNodeCapabilities
        {
            get { return GroupCapabilities.Single; } //SiblingMixedType
        }

        public virtual GroupCapabilities PasteIntoNodeCapabilities
        {
            get { return GroupCapabilities.Single; }
        }

        public virtual GroupCapabilities SearchNodeCapabilites
        {
            get { return GroupCapabilities.Single; }
        }

        public virtual GroupCapabilities ReorderNodeCapabilities
        {
            get { return GroupCapabilities.Single; } //SiblingMixedType
        }

        public virtual GroupCapabilities RefreshNodeCapabilites
        {
            get { return GroupCapabilities.Single; } // MultiMixedType | ElideChildren
        }

        #endregion

        #region Operations

        public virtual bool CreateNode (TagType type)
        {
            return false;
        }

        public virtual bool RenameNode ()
        {
            return false;
        }

        public virtual bool EditNode ()
        {
            return false;
        }

        public virtual bool DeleteNode ()
        {
            return false;
        }

        public virtual bool CopyNode ()
        {
            return false;
        }

        public virtual bool CutNode ()
        {
            return false;
        }

        public virtual bool PasteNode ()
        {
            return false;
        }

        public virtual bool ChangeRelativePosition (int offset)
        {
            return false;
        }

        public virtual bool RefreshNode ()
        {
            return false;
        }
        
        public string toJSON ()
        {
          return toJSON(null).ToString();
        }
        
        internal virtual System.Text.StringBuilder toJSON(System.Text.StringBuilder Builder) {
          if(Builder == null)
            Builder = new System.Text.StringBuilder();
          if(_children.Count < 1)
            ExpandCore();
          Builder.Append("{");
          bool isFirst = true;
          foreach(DataNode _child in _children) {
            if(!isFirst)
              Builder.Append(",");
            else
              isFirst = false;
            Builder.Append(_child.NodeName).Append(":");
            _child.toJSON(Builder);
          }
          Builder.Append("}");
          return Builder;
        }
          

        #endregion
    }
}
