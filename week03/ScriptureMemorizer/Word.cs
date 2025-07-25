public class Word
{
    private readonly string _originalText;

    // Say if the word is hidden or showing
    private bool _isHidden;

    public Word(string text)
    {
        _originalText = text;
        _isHidden = false;
    }

// Hide the word by setting _isHidden to true
    public void Hide()
    {
        _isHidden = true;
    }

// Show the word again by setting _isHidden to false
    public void Show()
    {
        _isHidden = false;
    }

// This tells us if the word is hidden (true or false)
    public bool IsHidden => _isHidden;

// This gives the original word text
    public string Text => _originalText;

// If the word is hidden, show blanks; if not, show the word
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _originalText.Length) : _originalText;
    }
}


