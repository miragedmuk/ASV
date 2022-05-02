using System;

namespace SavegameToolkit {

    public class BaseOptions {
        /// <summary>
        /// Should memory mapping be used when processing binary data?
        /// </summary>
        /// <returns>whether memory mapping will be used when processing binary data</returns>
        public bool UsesMemoryMapping { get; private set; } = true;

        /// <summary>
        /// Should data be processed in parallel}?
        /// </summary>
        /// <returns></returns>
        public bool IsParallel { get; private set; }

        /// <summary>
        /// The amount of thread to use for parallel operations
        /// </summary>
        public int ThreadCount { get; private set; } = Environment.ProcessorCount;

        /// <summary>
        /// Compact output.
        /// </summary>
        public bool Compact { get; private set; } = false;

        public static BaseOptions Create() {
            return new BaseOptions();
        }

        /// <summary>
        /// Sets whether memory mapping will be used when processing binary data.
        /// </summary>
        /// <param name="memoryMapping"></param>
        /// <returns>self</returns>
        public BaseOptions WithMemoryMapping(bool memoryMapping) {
            UsesMemoryMapping = memoryMapping;
            return this;
        }

        /// <summary>
        /// Sets where data will be processed in parallel.
        /// </summary>
        /// <param name="parallel"></param>
        /// <returns>self</returns>
        public BaseOptions Parallel(bool parallel) {
            IsParallel = parallel;
            return this;
        }

        /// <summary>
        /// Sets the amount of threads to use
        /// </summary>
        /// <param name="threadCount">amount of threads to use</param>
        /// <returns>self</returns>
        public BaseOptions WithThreadCount(int threadCount) {
            if (threadCount < 1) {
                throw new ArgumentException("ThreadCount must not be lower than 1");
            }
            ThreadCount = threadCount;
            return this;
        }

        /// <summary>
        /// Sets whether the output should be more compact or not.
        /// </summary>
        /// <param name="compact"></param>
        /// <returns>self</returns>
        public BaseOptions CompactOutput(bool compact) {
            Compact = compact;
            return this;
        }


    }

}
