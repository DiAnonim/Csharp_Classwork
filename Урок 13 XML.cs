using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;

class Person
{
    string name;
    string Lname;
    string age;

    public Person(string name, string L, string age)
    {
        this.name = name;
        this.Lname = L;
        this.age = age;
    }

    public void saveXML()
    {
        XmlWriter xml = null;
        try
        {
            xml = XmlWriter.Create($"D:\\{name}_{Lname}.xml");
            xml.WriteStartDocument();

            xml.WriteStartElement("Person");
            xml.WriteElementString("Name", name);
            xml.WriteElementString("LName", Lname);
            xml.WriteElementString("Age", age);
            xml.WriteEndElement();
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
        finally
        {
            if (xml != null) xml.Close();
        }

    }
}

class Program
{
    static void ReadNode(XmlNode root)
    {
        WriteLine($"Type={root.NodeType}\tRootName={root.Name}\tRootValue={root.Value}");
        if(root.HasChildNodes)
        {
            foreach(XmlNode node in root.ChildNodes)
            {
                ReadNode(node);
            }
        }
    }

    static void Appened(XmlDocument xml)
    {
        XmlNode root = xml.DocumentElement;

        XmlNode boat = xml.CreateElement("Boat");
        XmlNode carName = xml.CreateElement("Name");
        XmlNode boatName = xml.CreateTextNode("Saint Jones");
        carName.AppendChild(boatName);
        boat.AppendChild(carName);

        root.AppendChild(boat);
        xml.Save(@"D:\Cars2.xml");
    }

    static void Main()
    {
        Person p1 = new("Diana", "Akobyan", "20");
        p1.saveXML();

        try
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"D:\Cars.xml");
            ReadNode(xml.DocumentElement);
            Appened(xml);
        }
        catch(Exception ex)
        {
            WriteLine(ex);
        }

        /*XmlWriter xml = null;

        try
        {

            xml = XmlWriter.Create(@"D:\Cars.xml");
            xml.WriteStartDocument();
            xml.WriteStartElement("Cars");
            //1
            xml.WriteStartElement("Car");
            xml.WriteAttributeString("Image", "MyCar.jpg"); ;
            xml.WriteElementString("Model", "Mozeraty");
            xml.WriteElementString("Year", "1912");
            xml.WriteElementString("Color", "red");
            xml.WriteElementString("Speed", "180");
            xml.WriteEndElement();
            //2
            xml.WriteStartElement("Car");
            xml.WriteAttributeString("Image", "MyCar2.jpg"); ;
            xml.WriteElementString("Model", "Lamborgini");
            xml.WriteElementString("Year", "1975");
            xml.WriteElementString("Color", "blue");
            xml.WriteElementString("Speed", "200");
            xml.WriteEndElement();
            //End
            xml.WriteEndElement();
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
        finally
        {
            if (xml != null) xml.Close();
        }*/
    }
}