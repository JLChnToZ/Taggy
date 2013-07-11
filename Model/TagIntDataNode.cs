using Substrate.Nbt;

namespace Taggy.Model
{
    public class TagIntDataNode : TagDataNode
    {
        public TagIntDataNode (TagNodeInt tag)
            : base(tag)
        { }

        public override bool EditNode ()
        {
            return EditScalarValue(Tag);
        }
    }
}
