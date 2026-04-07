using System.Collections;
using System.Collections.Generic;
namespace Week10_Pylypenko;

public class Party:IEnumerable<Character>
{
  private readonly List<Character> _characters = new List<Character>();

  public void Add(Character character)
  {
    _characters.Add(character);
  }

  public IEnumerator<Character> GetEnumerator()
  {
    foreach (var character in _characters)
    {
      yield return character;
    }
  }
   IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public IEnumerator<Character> GetActiveCharacters()
  {
    foreach (Character c in _characters )
    {
      if (c.Status == CharacterStatus.Active)
      {
        yield return c; 
      }
    }
  }
  public IEnumerator<Character> GetLowHP(int HpLimit)
  {
    foreach (Character c in _characters )
    {
      if (c.Welbeeing<HpLimit)
      {
        yield return c; 
      }
    }
  }
}