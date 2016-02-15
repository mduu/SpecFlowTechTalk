namespace SpecFlow.App
{
    /// <summary>
    /// Basic calculator for testing SpecFlow.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Sets the first number for the math operation.
        /// </summary>
        /// <value>The first number.</value>
        public int FirstNumber { set; private get; }

        /// <summary>
        /// Sets the second number for the math operation.
        /// </summary>
        /// <value>The second number.</value>
        public int SecondNumber { set; private get; }

        /// <summary>
        /// Adds <see cref="FirstNumber"/> and <see cref="SecondNumber"/> and
        /// returns the result.
        /// </summary>
        /// <seealso cref="FirstNumber"/>
        /// <seealso cref="SecondNumber"/>
        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        /// <summary>
        /// Subtracts <see cref="SecondNumber"/> from <see cref="FirstNumber"/>
        /// and returns the result.
        /// </summary>
        /// <seealso cref="FirstNumber"/>
        /// <seealso cref="SecondNumber"/>
        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }
    }
}
