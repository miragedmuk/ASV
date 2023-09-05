using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;

namespace SavegameToolkit.Types {

    public sealed class ArkName : IComparable<ArkName>, IComparable, IEquatable<ArkName> {

        private readonly string content;

        public string Name { get; }

        public int Instance { get; }

        
        private static readonly Regex nameIndexPattern = new Regex("^(.*)_([0-9]+)$");

        private static ThreadLocal<IDictionary<string, ArkName>> _nameCache = new ThreadLocal<IDictionary<string, ArkName>>(() =>
        {
            return new Dictionary<string, ArkName>();
        });
        
        ThreadLocal<int> local = new ThreadLocal<int>(() =>
        {
            return 10;
        });

        private static readonly Dictionary<string, ArkName> constantNameCache = new Dictionary<string, ArkName>();

        public static readonly ArkName NameNone = ConstantPlain("None");

        private ArkName(string content) {

            Match matcher = nameIndexPattern.Match(content);
            if (matcher.Success) {
                Name = matcher.Groups[1].Value;
                Instance = int.Parse(matcher.Groups[2].Value) + 1;
            } else {
                Name = content;
                Instance = 0;
            }
            this.content = content;
        }

        private ArkName(string name, int instance, string content) {
            
            Name = name;
            Instance = instance;
            this.content = content;
        }

        #region creation function

        /// <summary>
        /// Creates or retrieves an ArkName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ArkName From(string name) {

            if (name == null || !_nameCache.Value.TryGetValue(name, out ArkName value)) {
                value = new ArkName(name);
                _nameCache.Value.Add(name, value);
            }
            return value;
        }

        /// <summary>
        /// Creates or retrieves an ArkName
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static ArkName From(string name, int instance) {
            string instanceName = instance == 0 ? name : $"{name}_{instance - 1}";

            if (instanceName == null || !_nameCache.Value.TryGetValue(instanceName, out ArkName value)) {
                value = new ArkName(name, instance, instanceName);
                _nameCache.Value.Add(instanceName, value);
            }
            return value;
        }

        /// <summary>
        /// Creates or retrieves an ArkName with instance 0
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ArkName FromPlain(string name) => From(name, 0);

        /// <summary>
        /// Creates or retrieves a permanent ArkName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ArkName Constant(string name) {
            if (name == null || !_nameCache.Value.TryGetValue(name, out ArkName value))
            {
                value = new ArkName(name);
                _nameCache.Value.Add(name, value);
            }
            constantNameCache[name] = value;
            return value;
        }

        /// <summary>
        /// Creates or retrieves a permanent ArkName
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static ArkName Constant(string name, int instance) {
            string instanceName = instance == 0 ? name : $"{name}_{instance - 1}";
            if (instanceName == null || !_nameCache.Value.TryGetValue(instanceName, out ArkName value)) {
                value = new ArkName(name, instance, instanceName);
                _nameCache.Value.Add(instanceName, value);
            }
            constantNameCache[instanceName] = value;
            return value;
        }

        /// <summary>
        /// Creates or retrieves an permanent ArkName with instance 0
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ArkName ConstantPlain(string name) => Constant(name, 0);

        #endregion

        public static void ClearCache() {
            _nameCache = new ThreadLocal<IDictionary<string, ArkName>>() { Value = new Dictionary<string, ArkName>() };
        }

        public override string ToString() => content;


        #region Equality members

        public override int GetHashCode() => content != null ? content.GetHashCode() : 0;

        public override bool Equals(object other) {
            return !(other is null) && (ReferenceEquals(this, other) || Equals(other as ArkName));
        }

        public bool Equals(ArkName other) {
            return !(other is null) && (ReferenceEquals(this, other) || string.Equals(content, other.content));
        }

        public static bool operator ==(ArkName left, ArkName right) {
            return Equals(left, right);
        }

        public static bool operator !=(ArkName left, ArkName right) {
            return !Equals(left, right);
        }

        #endregion

        #region Relational members

        public int CompareTo(ArkName other) {
            return ReferenceEquals(this, other) ? 0 : (other is null ? 1 : string.Compare(content, other.content, StringComparison.Ordinal));
        }

        public int CompareTo(object obj) {
            return (obj is null) ? 1 : (ReferenceEquals(this, obj) ? 0 : (obj is ArkName other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(ArkName)}")));
        }

        public static bool operator <(ArkName left, ArkName right) {
            return Comparer<ArkName>.Default.Compare(left, right) < 0;
        }

        public static bool operator >(ArkName left, ArkName right) {
            return Comparer<ArkName>.Default.Compare(left, right) > 0;
        }

        public static bool operator <=(ArkName left, ArkName right) {
            return Comparer<ArkName>.Default.Compare(left, right) <= 0;
        }

        public static bool operator >=(ArkName left, ArkName right) {
            return Comparer<ArkName>.Default.Compare(left, right) >= 0;
        }

        #endregion
    }

}
