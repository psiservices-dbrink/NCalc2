﻿using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;

namespace NCalc
{
    internal class ErrorListener<T> : IAntlrErrorListener<T>
    {
        public readonly List<SyntaxError<T>> Errors = new();

        public void SyntaxError(TextWriter output, IRecognizer recognizer, T offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            Errors.Add(new SyntaxError<T>(offendingSymbol, line, charPositionInLine, msg, e));
        }
    }
}
