using System.Text.RegularExpressions;

namespace AsaSavegameToolkit.Types
{
    public sealed class AsaName : IComparable<AsaName>, IComparable, IEquatable<AsaName>
    {

        private readonly string content;

        public string Name { get; }

        public int Instance { get; }


        private static readonly Regex nameIndexPattern = new Regex("^(.*)_([0-9]+)$");

        private static ThreadLocal<IDictionary<string, AsaName>> _nameCache = new ThreadLocal<IDictionary<string, AsaName>>(() =>
        {
            return new Dictionary<string, AsaName>();
        });

        ThreadLocal<int> local = new ThreadLocal<int>(() =>
        {
            return 10;
        });

        private static readonly Dictionary<string, AsaName> constantNameCache = new Dictionary<string, AsaName>();

        public static readonly AsaName NameNone = ConstantPlain("None");

        private AsaName(string content)
        {

            Match matcher = nameIndexPattern.Match(content);
            if (matcher.Success)
            {
                Name = matcher.Groups[1].Value;
                Instance = int.Parse(matcher.Groups[2].Value) + 1;
            }
            else
            {
                Name = content;
                Instance = 0;
            }
            this.content = content;
        }

        private AsaName(string name, int instance, string content)
        {

            Name = name;
            Instance = instance;
            this.content = content;
        }

        #region creation function

        /// <summary>
        /// Creates or retrieves an AsaName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static AsaName From(string name)
        {

            if (name == null || !_nameCache.Value.TryGetValue(name, out AsaName value))
            {
                value = new AsaName(name);
                _nameCache.Value.Add(name, value);
            }
            return value;
        }

        /// <summary>
        /// Creates or retrieves an AsaName
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static AsaName From(string name, int instance)
        {
            string instanceName = instance == 0 ? name : $"{name}_{instance - 1}";

            if (instanceName == null || !_nameCache.Value.TryGetValue(instanceName, out AsaName value))
            {
                value = new AsaName(name, instance, instanceName);
                _nameCache.Value.Add(instanceName, value);
            }
            return value;
        }

        /// <summary>
        /// Creates or retrieves an AsaName with instance 0
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static AsaName FromPlain(string name) => From(name, 0);

        /// <summary>
        /// Creates or retrieves a permanent AsaName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static AsaName Constant(string name)
        {
            if (name == null || !_nameCache.Value.TryGetValue(name, out AsaName value))
            {
                value = new AsaName(name);
                _nameCache.Value.Add(name, value);
            }
            constantNameCache[name] = value;
            return value;
        }

        /// <summary>
        /// Creates or retrieves a permanent AsaName
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static AsaName Constant(string name, int instance)
        {
            string instanceName = instance == 0 ? name : $"{name}_{instance - 1}";
            if (instanceName == null || !_nameCache.Value.TryGetValue(instanceName, out AsaName value))
            {
                value = new AsaName(name, instance, instanceName);
                _nameCache.Value.Add(instanceName, value);
            }
            constantNameCache[instanceName] = value;
            return value;
        }

        /// <summary>
        /// Creates or retrieves an permanent AsaName with instance 0
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static AsaName ConstantPlain(string name) => Constant(name, 0);

        #endregion

        public static void ClearCache()
        {
            _nameCache = new ThreadLocal<IDictionary<string, AsaName>>() { Value = new Dictionary<string, AsaName>() };
        }

        public override string ToString() => content;


        #region Equality members

        public override int GetHashCode() => content != null ? content.GetHashCode() : 0;

        public override bool Equals(object other)
        {
            return !(other is null) && (ReferenceEquals(this, other) || Equals(other as AsaName));
        }

        public bool Equals(AsaName other)
        {
            return !(other is null) && (ReferenceEquals(this, other) || string.Equals(content, other.content));
        }

        public static bool operator ==(AsaName left, AsaName right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AsaName left, AsaName right)
        {
            return !Equals(left, right);
        }

        #endregion

        #region Relational members

        public int CompareTo(AsaName other)
        {
            return ReferenceEquals(this, other) ? 0 : (other is null ? 1 : string.Compare(content, other.content, StringComparison.Ordinal));
        }

        public int CompareTo(object obj)
        {
            return (obj is null) ? 1 : (ReferenceEquals(this, obj) ? 0 : (obj is AsaName other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(AsaName)}")));
        }

        public static bool operator <(AsaName left, AsaName right)
        {
            return Comparer<AsaName>.Default.Compare(left, right) < 0;
        }

        public static bool operator >(AsaName left, AsaName right)
        {
            return Comparer<AsaName>.Default.Compare(left, right) > 0;
        }

        public static bool operator <=(AsaName left, AsaName right)
        {
            return Comparer<AsaName>.Default.Compare(left, right) <= 0;
        }

        public static bool operator >=(AsaName left, AsaName right)
        {
            return Comparer<AsaName>.Default.Compare(left, right) >= 0;
        }

        #endregion
    }
}
