﻿using System;
using System.IO;
using PerCederberg.Grammatica.Runtime;
using System.Collections.Generic;

namespace Syntax_Analyzer
{
    public class SyntaxInitializer
    {
        public string Start(List<string> tokens)
        {

            string tokenstream = "";
            string result;

            foreach (string t in tokens)
            {
                tokenstream += t + " ";
            }
            tokenstream = tokenstream.TrimEnd();

            Parser p;
            p = CreateParser(tokenstream);

            try
            {
                p.Parse();
                Fail("parsing succeeded");
                result = "Syntax Analyzer Succeeded...";
            }
            catch (ParserCreationException e)
            {
                Fail(e.Message);
                result = e.Message;
            }
            catch (ParserLogException e)
            {
                result = e[0].ErrorMessage;
            }
            return result;
        }

        private Parser CreateParser(string input)
        {
            Parser parser = null;

            try
            {
                parser = new SyntaxParser(new StringReader(input));
                parser.Prepare();
            }
            catch (ParserCreationException e)
            {
                Fail(e.Message);
            }
            return parser;
        }

        protected void Fail(string message)
        {
            if (message != "parsing succeeded")
                throw new Exception(message);
        }
    }
}
