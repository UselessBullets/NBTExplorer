using System;
using Substrate.Nbt;

namespace NBTExplorer.Model {
    public class TagDoubleArrayDataNode : TagDataNode {
        public TagDoubleArrayDataNode(TagNodeDoubleArray tag)
            : base(tag) { }

        protected new TagNodeDoubleArray Tag {
            get { return base.Tag as TagNodeDoubleArray; }
        }

        public override bool CanEditNode {
#if WINDOWS
            get { return true; }
#else
            get { return false; }
#endif
        }

        public override bool EditNode() {
            return EditLongHexValue(Tag);
        }

        public override string NodeDisplay {
            get { return NodeDisplayPrefix + Tag.Data.Length + " double floats"; }
        }
    }
}