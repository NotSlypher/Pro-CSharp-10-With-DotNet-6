namespace ProductPortal.Exceptions
{
    public class NoProductsException : ApplicationException
    {
        public override string Message => "No Products Found";
    }
}
