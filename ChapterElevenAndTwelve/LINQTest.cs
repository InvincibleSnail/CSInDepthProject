using System.Xml.Linq;

namespace CSInDepthProject.ChapterElevenAndTwelve;

public class LINQTest
{
    public LINQTest()
    {
        var path = "D:\\CSInDepthProject\\ChapterElevenAndTwelve\\test.xml";
        XDocument doc = XDocument.Load(path);  
        XElement root = doc.Root;  
  
        foreach (XElement person in root.Elements("Person"))  
        {  
            XElement nameElement = person.Element("Name");  
            XElement ageElement = person.Element("Age");  
  
            if (nameElement != null && ageElement != null)  
            {  
                Console.WriteLine($"Name: {nameElement.Value}, Age: {ageElement.Value}");  
            }  
        }   
  
        Console.ReadKey();  
    }
}