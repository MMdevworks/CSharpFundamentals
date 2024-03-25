using System;

namespace Comments
{
    class Program
    {
        /// XML comments are used to help provide documentation https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
        /// Modify csproj file to include:
        /// <GenerateDocumentationFile>true</GenerateDocumentationFile>
        /// <DocumentationFile>Name.xml</DocumentationFile>
        /// Run dotnet build to build and generate the documentation
        /// They start with triple slashes and have special syntax, examples:
        /// <summary>
        /// This is the main sample application function
        /// </summary>
        /// <param name='args'> An array of string arguments from the command line</param>
        /// <returns>
        /// No return value
        /// </returns>
        static void Main(string[] args)
        {
        // Double slash for single line comments
        // For shorter comment lines

        /* Multiline comments start with a slash and star.  
        They are used for larger blocks of commented
        text and end with the star and slash */
        }
    }
}