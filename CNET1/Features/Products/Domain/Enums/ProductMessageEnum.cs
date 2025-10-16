namespace CNET1.Features.Products.Domain.Enums
{
    public record ProductMessageEnum(string Code, string Message)
    {
        public static readonly ProductMessageEnum PRODUCT_ERROR = new("PROD-1", "There is an error with this product");
        public static readonly ProductMessageEnum SKU_BLANK = new("PROD-2", "SKU is blank");
        public static readonly ProductMessageEnum SKU_REPEATED = new("PROD-3", "This SKU already exists");
        public static readonly ProductMessageEnum NAME_BLANK = new("PROD-4", "Name is blank");
        public static readonly ProductMessageEnum CATEGORY_NULL = new("PROD-4", "Category is emtpy");
        public static readonly ProductMessageEnum DESCRIPTION_BLANK = new("PROD-5", "Description is blank");
        public static readonly ProductMessageEnum SKU_MIN = new("PROD-6", "SKU is shorter");
        public static readonly ProductMessageEnum UNIT_PRICE_MIN = new("PROD-7", "Unit Price has to be a positive value");
        public static readonly ProductMessageEnum UNIT_PRICE_NULL = new("PROD-8", "Unit Price is empty");
        public static readonly ProductMessageEnum UNIT_IN_STOCK_NULL = new("PROD-9", "Unit In Stock is empty");
        public static readonly ProductMessageEnum UNIT_IN_STOCK_MIN = new("PROD-10", "Unit In Stock has to be a positive value");
        public static readonly ProductMessageEnum CATEGORY_NOT_EXIST = new("PROD-11", "This category does not exist");
        public static readonly ProductMessageEnum SKU_NOT_EXIST = new("PROD-12", "This SKU does not exist");
        public static readonly ProductMessageEnum IS_ACTIVE_NULL = new("PROD-13", "Field isActive is empty");
        public static readonly ProductMessageEnum PRODUCT_NOT_EXIST = new("PROD-14", "There is no product with this SKU");
    }
}
