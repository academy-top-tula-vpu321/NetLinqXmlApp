using System.Xml.Linq;

//XDocument xDocument  = new XDocument();
//XElement xElement = new XElement("Employees");
//xDocument.Add(xElement);

//XElement xElementBob = new XElement("Employee");
//XAttribute xAttributeBobType = new XAttribute("type", "manager");

//xElementBob.Add(xAttributeBobType);
//xElementBob.Add(new XElement("Name", "Bob"));
//xElementBob.Add(new XElement("Age", 35));

//xElement.Add(xElementBob);

//xElement.Add(
//    new XElement("Employee",
//        new XAttribute("type", "saller"),
//        new XElement("Name", "Joe"),
//        new XElement("Age", 29)
//        )
//    );

//xDocument.Save("employees.xml");

XDocument xDocument = XDocument.Load("employees.xml");
foreach (var e in xDocument.Element("Employees")
                           .Elements()
                           .Where(e => Int32.Parse(e.Element("Age").Value) > 30))
{
    foreach(var attr in e.Attributes())
        Console.WriteLine($"Attr: {attr.Name} -> {attr.Value}");
    foreach(var item in e.Elements())
        Console.WriteLine($"Field: {item.Name} -> {item.Value}");
}
    