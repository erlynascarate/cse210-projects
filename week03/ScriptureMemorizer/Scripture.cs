public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] array = text.Split(" ");
        foreach (string a in array)
        {
            Word word = new Word(a);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            Word word;
            do
            {
                int index = randomGenerator.Next(0, _words.Count);
                
                word = _words[index];
            } while(word.IsHidden() && !IsCompletelyHidden());
            word.Hide();
        }
    }
    public string GetDisplayText()
    {
        string[] text = _words.Select(word => word.GetDisplayText()).ToArray();
        string displayText = string.Join(" ", text);

        string referenceText = _reference.GetDisplayText();

        return $"{referenceText} {displayText}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}