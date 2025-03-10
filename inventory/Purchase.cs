using System;

public class Purchase
{
    private Inventory inventory;
    private PurchaseHistory history;

    public Purchase(Inventory inv, PurchaseHistory hist)
    {
        inventory = inv;
        history = hist;
    }

    public void BuyProduct(string product, int quantity)
    {
        if (inventory.RemoveStock(product, quantity))
        {
            history.AddRecord(product, quantity);
            Console.WriteLine($"購入成功: {product} x {quantity}");
        }
        else
        {
            Console.WriteLine("エラー: 在庫が不足しています"); // ✅ ここでエラーを表示する修正が必要
        }
    }
}
