using Substrate.Nbt;

namespace Taggy.Model
{
    public class TagDoubleDataNode : TagDataNode
    {
        public TagDoubleDataNode (TagNodeDouble tag)
            : base(tag)
        { }

        public override bool EditNode ()
        {
            return EditScalarValue(Tag);
        }
    }
}
