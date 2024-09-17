namespace AsaSaveReader.Models
{
    internal interface IAsaPropertyObject
    {
        string Name { get; set; }
    }

    internal interface IAsaPropertyObject<T> : IAsaPropertyObject
    {
        T Value { get; set; }
    }
}