using System;
using Substrate.Nbt;

namespace Taggy.Model
{
    public class TagIntArrayDataNode : TagDataNode
    {
        public TagIntArrayDataNode (TagNodeIntArray tag)
            : base(tag)
        { }

        protected new TagNodeIntArray Tag
        {
            get { return base.Tag as TagNodeIntArray; }
        }

        public override bool CanEditNode
        {
            get { return !IsMono(); }
        }

        public override bool EditNode ()
        {
            return EditIntHexValue(Tag);
        }

        public override string NodeDisplay
        {
            get { return NodeDisplayPrefix + Tag.Data.Length + " 個整數"; }
        }

        private bool IsMono ()
        {
            return Type.GetType("Mono.Runtime") != null;
        }
    }
}
