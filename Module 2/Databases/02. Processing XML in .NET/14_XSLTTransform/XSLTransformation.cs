namespace XSLTransformation
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Xml.Xsl;

    public static class XSLTransformation
    {
        private static void Main()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../../catalog.xslt");
            xslt.Transform("../../../catalog.xml", "../../../catalog.html");

            Process.Start(Path.Combine(Environment.CurrentDirectory, "../../../catalog.html"));
        }
    }
}