class Document:IPrintable,ISavable
{
    public void Print()
    {
        Console.WriteLine("Documnent printed");
    }
    public void Save()
    {
        Console.WriteLine("Document Saved");
    }
}