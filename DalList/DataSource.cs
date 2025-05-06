using DO;
namespace DalList;

static internal class DataSource
{
    internal static List<Client?> Clients = new List<Client?>();
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Sale?> Sales = new List<Sale?>();
    static internal class Config
    {
        // שדה קבוע עבור כל ישות, המגדיר את המזהה ההתחלתי
        internal const int ProductMinId = 200;
        internal const int SaleMinId = 300;

        // שדות סטטיים פרטיים עבור כל מזהה רץ
        private static int ProductIdCounter = ProductMinId;
        private static int SaleIdCounter = SaleMinId;

        // מאפיינים עם get בלבד שמחזירים את הערך ומקדמים אותו אוטומטית
        internal static int ProductId
        {
            get { return ProductIdCounter++; }
        }
        internal static int SaleId
        {
            get { return SaleIdCounter++; }
        }
    }
}
