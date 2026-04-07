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
   
  
}