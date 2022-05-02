using System;
using System.Collections.Generic;
using System.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit {

    public interface IPropertyContainer {
        List<IProperty> Properties { get; }

        //IProperty getProperty(string name, int index = 0);
        //IProperty findProperty(string name, int index = 0);

        //T getTypedProperty<T>(string name, int index = 0) where T : IProperty;
        //T findTypedProperty<T>(string name, int index = 0) where T : IProperty;

        //T getPropertyValue<T>(string name, int index = 0, T defaultValue = default(T));
        //T findPropertyValue<T>(string name, int index = 0, T defaultValue = default(T));
        //U findPropertyValue<T, U>(string name, int index = 0, U defaultValue = default(U), Func<T, U> map = null);

        //bool hasAnyProperty(string name);
    }

    public static class PropertyContainerExtensions {
        //public static IProperty getProperty(PropertyContainer propertyContainer, string name, int index = 0) {
        //    foreach (IProperty prop in propertyContainer.Properties) {
        //        if (prop.Index == index && prop.NameString == name) {
        //            return prop;
        //        }
        //    }

        //    return null;
        //}

        public static T GetTypedProperty<T>(this IPropertyContainer propertyContainer, string name, int index = 0) where T : IProperty {
            foreach (IProperty prop in propertyContainer.Properties) {
                if (prop.Index == index && prop.NameString == name && prop is T variable) {
                    return variable;
                }
            }

            return default(T);
        }

        public static T GetPropertyValue<T>(this IPropertyContainer propertyContainer, string name, int index = 0, T defaultValue = default(T)) {
            foreach (IProperty<T> prop in propertyContainer.Properties.OfType<IProperty<T>>()) {
                if (prop.Index == index && prop.NameString == name && prop.Value is T variable) {
                    return variable;
                }
            }

            return defaultValue;
        }

        public static U GetPropertyValue<T, U>(this IPropertyContainer propertyContainer, string name, int index = 0, U defaultValue = default(U), Func<T, U> map = null) {
            T value = propertyContainer.GetPropertyValue<T>(name, index);
            if (value == null || value.Equals(default(T))) {
                return defaultValue;
            }
            if (map != null) {
                return map(value);
            }
            return (U)(object)value;
        }

        public static bool HasAnyProperty(this IPropertyContainer propertyContainer, string name) {
            return propertyContainer.Properties.Any(p => p.NameString == name);
        }
    }

}
