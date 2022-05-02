namespace SavegameToolkit {

    public class WritingOptions : BaseOptions {
        public new static WritingOptions Create() {
            return new WritingOptions();
        }

        public new WritingOptions Parallel(bool parallel) {
            base.Parallel(parallel);
            return this;
        }

        public new WritingOptions WithMemoryMapping(bool memoryMapping) {
            base.WithMemoryMapping(memoryMapping);
            return this;
        }

        public new WritingOptions WithThreadCount(int threadCount) {
            base.WithThreadCount(threadCount);
            return this;
        }

        public new WritingOptions CompactOutput(bool compact) {
            base.CompactOutput(compact);
            return this;
        }

    }

}
