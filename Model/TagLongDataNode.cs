using Substrate.Nbt;

namespace Taggy.Model
{
    public class TagLongDataNode : TagDataNode
    {
        public TagLongDataNode (TagNodeLong tag)
            : base(tag)
        { }

        public override bool EditNode ()
        {
            return EditScalarValue(Tag);
        }
    }
}
