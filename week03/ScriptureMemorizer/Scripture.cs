using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;
    private readonly Random _rng = new();

// This break the verse into little words, then turn each word into a Word object and save them in a list.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }

// It get how each word looks (maybe hidden), join them together,
// and add the reference at the top.
    public string GetDisplayText()
    {
        var joinedText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{joinedText}";
    }

    public void HideRandomWords(int count)
    {
        // It look for all words that are still showing.
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _rng.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

// It check if every word is hidden. If yes, I return true.
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }

// It count how many words are still showing.
    public int VisibleWordCount()
    {
        return _words.Count(w => !w.IsHidden);
    }

    public List<Word> GetVisibleWords()
    {   
        // It  make a list of the words that are still showing.
        return _words.Where(w => !w.IsHidden).ToList();
    }
}



