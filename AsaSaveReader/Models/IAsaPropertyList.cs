namespace AsaSaveReader.Models
{

    internal interface IAsaPropertyList
    {
        string Name { get; set; }
    }
    internal interface IAsaPropertyList<T> : IAsaPropertyList
    {
        List<AsaPropertyObject<T>> Value { get; set; }
    }
}