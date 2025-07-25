public class Reference
{   
    // Keep the reference safe (only this class can use it)
    private readonly string _reference;

    // Save the reference when creating a new object
    public Reference(string reference)
    {
        _reference = reference;
    }
    // Give back the saved reference
    public string GetDisplayText()
    {
        return _reference;
    }
}
