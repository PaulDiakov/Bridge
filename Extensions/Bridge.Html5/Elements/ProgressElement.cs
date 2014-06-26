﻿using System;
using Bridge.CLR;

namespace Bridge.Html5
{
    /// <summary>
    /// The HTMLProgressElement interface provides special properties and methods (beyond the regular HTMLElement interface it also has available to it by inheritance) for manipulating the layout and presentation of <progress> elements.
    /// </summary>
    [Ignore]
    [Name("HTMLProgressElement")]
    public class ProgressElement : Element
    {
        [Template("document.createElement('progress')")]
        public ProgressElement()
        {
        }

        /// <summary>
        /// Is a double value reflecting the content attribute of the same name, limited to numbers greater than zero. Its default value is 1.0.
        /// </summary>
        public double Max;

        /// <summary>
        /// Returns a double value returning the result of dividing the current value (value) by the maximum value (max); if the progress bar is an indeterminate progress bar, it returns -1.
        /// </summary>
        public readonly string Position;

        /// <summary>
        /// Is a double value returning  the current value; if the progress bar is an indeterminate progress bar, it returns 0.
        /// </summary>
        public new double Value;

        /// <summary>
        /// Returns NodeList containing the list of <label> elements that are labels for this element.
        /// </summary>
        public NodeList Labels;
    }
}