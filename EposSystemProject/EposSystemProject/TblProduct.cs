namespace EposSystemProject
{
    internal class TblProduct
    {
        internal string Description;
        internal decimal Price;

        public object Image { get; internal set; }
        public int ProductType { get; internal set; }
    }
}