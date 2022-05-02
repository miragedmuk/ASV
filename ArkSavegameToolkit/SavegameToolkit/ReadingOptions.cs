using System;

namespace SavegameToolkit {

    public class ReadingOptions : BaseOptions {
        /// <summary>
        /// Whether the names of data files will be read or skipped over.
        /// 
        /// <code>true</code> if reading, <code>false</code> if skipping
        /// </summary>
        public bool DataFiles { get; private set; } = true;

        /// <summary>
        /// Whether embedded binary data will be read or skipped over.
        /// 
        /// <code>true</code> if reading, <code>false</code> if skipping
        /// </summary>
        public bool EmbeddedData { get; private set; } = true;

        public bool DataFilesObjectMap { get; private set; } = true;

        /// <summary>
        /// Whether game objects will be read or skipped over.
        /// 
        /// <code>true</code> if reading, <code>false</code> if skipping
        /// </summary>
        public bool GameObjects { get; private set; } = true;

        /// <summary>
        /// Whether <see cref="GameObject"/> properties will be read or skipped over.
        /// <see cref="GameObjects"/> needs to be <code>true</code> for this to have any effect.
        ///
        /// <seealso cref="WithObjectFilter"/>
        /// @return <code>true</code> if reading, <code>false</code> if skipping
        /// </summary>
        public bool GameObjectProperties { get; private set; } = true;

        /// <summary>
        /// Determines which objects properties will be loaded. <see cref="GameObjects"/> needs to be
        /// <code>true</code> for this to have any effect.
        /// </summary>
        public Predicate<GameObject> ObjectFilter { get; private set; }

        /// <summary>
        /// Whether hibernation data will be read or skipped over.
        ///
        /// <code>true</code> if reading, <code>false</code> if skipping
        /// </summary>
        public bool Hibernation { get; private set; } = true;

        /// <summary>
        /// Whether hibernation <see cref="GameObject"/> properties will be read or skipped over.
        /// <see cref="Hibernation"/> needs to be <code>true</code> for this to have any effect.
        ///
        /// <code>true</code> if reading, <code>false</code> if skipping
        /// </summary>
        public bool HibernationObjectProperties { get; private set; } = true;

        public bool BuildComponentTree { get; private set; }

        public bool StoredCreatures { get; set; } = false;

        public new static ReadingOptions Create() {
            return new ReadingOptions();
        }

        public ReadingOptions WithStoredCreatures(bool storedCreatures)
        {
            StoredCreatures = storedCreatures;
            return this;
        }

        /// <summary>
        /// Sets a filter on which objects properties will be loaded.
        /// <see cref="GameObjects"/> needs to be <code>true</code> for this to have any effect.
        /// </summary>
        /// <param name="objectFilter"></param>
        /// <returns>self</returns>
        public ReadingOptions WithObjectFilter(Predicate<GameObject> objectFilter) {
            ObjectFilter = objectFilter;
            return this;
        }

        /// <summary>
        /// Sets whether the names of data files will be read or skipped over.
        /// </summary>
        /// <param name="dataFiles"><code>true</code> if reading, <code>false</code> if skipping</param>
        /// <returns>self</returns>
        public ReadingOptions WithDataFiles(bool dataFiles) {
            DataFiles = dataFiles;
            return this;
        }

        /// <summary>
        /// Sets whether embedded binary data will be read or skipped over.
        /// </summary>
        /// <param name="embeddedData"><code>true</code> if reading, <code>false</code> if skipping</param>
        /// <returns>self</returns>
        public ReadingOptions WithEmbeddedData(bool embeddedData) {
            EmbeddedData = embeddedData;
            return this;
        }

        public ReadingOptions WithDataFilesObjectMap(bool dataFilesObjectMap) {
            DataFilesObjectMap = dataFilesObjectMap;
            return this;
        }

        /// <summary>
        /// Sets whether game objects will be read or skipped over.
        /// </summary>
        /// <param name="gameObjects"><code>true</code> if reading, <code>false</code> if skipping</param>
        /// <returns>self</returns>
        public ReadingOptions WithGameObjects(bool gameObjects) {
            GameObjects = gameObjects;
            return this;
        }

        /// <summary>
        /// Sets whether <see cref="GameObject"/> properties will be read or skipped over.
        /// <see cref="GameObjects"/> needs to be <code>true</code> for this to have any effect.
        /// <seealso cref="ObjectFilter"/>
        /// </summary>
        /// <param name="gameObjectProperties"><code>true</code> if reading, <code>false</code> if skipping</param>
        /// <returns>self</returns>
        public ReadingOptions WithGameObjectProperties(bool gameObjectProperties) {
            GameObjectProperties = gameObjectProperties;
            return this;
        }

        /// <summary>
        /// Sets whether hibernation data will be read or skipped over.
        /// </summary>
        /// <param name="hibernation"><code>true</code> if reading, <code>false</code> if skipping</param>
        /// <returns>self</returns>
        public ReadingOptions WithHibernation(bool hibernation) {
            Hibernation = hibernation;
            return this;
        }

        /// <summary>
        /// Sets whether hibernation <see cref="GameObject"/> properties will be read or skipped over.
        /// <see cref="Hibernation"/> needs to be <code>true</code> for this to have any effect.
        /// </summary>
        /// <param name="hibernationObjectProperties"><code>true</code> if reading, <code>false</code> if skipping</param>
        /// <returns>self</returns>
        public ReadingOptions WithHibernationObjectProperties(bool hibernationObjectProperties) {
            HibernationObjectProperties = hibernationObjectProperties;
            return this;
        }

        public ReadingOptions WithBuildComponentTree(bool buildComponentTree) {
            BuildComponentTree = buildComponentTree;
            return this;
        }

        public new ReadingOptions Parallel(bool parallel) {
            base.Parallel(parallel);
            return this;
        }

        public new ReadingOptions WithMemoryMapping(bool memoryMapping) {
            base.WithMemoryMapping(memoryMapping);
            return this;
        }

        public new ReadingOptions WithThreadCount(int threadCount) {
            base.WithThreadCount(threadCount);
            return this;
        }
    }

}
