using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// セレニウム操作を提供する管理クラス
/// </summary>
public class SeleniumManager
{
    // プロパティの定義はありません

    /// <summary>
    /// HTMLの「a」タグの中から、指定された文字列を含む最初のエレメントを取得する
    /// </summary>
    /// <param name="driver">SeleniumのWebドライバ</param>
    /// <param name="searchText">指定された文字列</param>
    /// <returns>最初に見つかったエレメント、見つからなかった場合はnull</returns>
    public IWebElement GetFirstAnchorElementByText(IWebDriver driver, string searchText)
    {
        // 戻り値用の変数をメソッド内の処理で定義し、デフォルト値（null）を設定する
        var resultElement = (IWebElement)null;

        if (driver == null)
        {
            Console.WriteLine("WebDriver is null.");
            return resultElement;
        }

        if (string.IsNullOrEmpty(searchText))
        {
            Console.WriteLine("Search text is null or empty.");
            return resultElement;
        }

        try
        {
            // HTMLに含まれる、すべての「a」タグを取得する。（LIST型）
            // By.TagName("a") で全てのアンカータグを取得
            var anchorElements = driver.FindElements(By.TagName("a"));

            // 上記の「a」タグのリストに対して、ループ処理を行う。
            foreach (var element in anchorElements)
            {
                // ループ処理の中で、「a」タグの配下に、引数で渡された「指定された文字列」が含まれる「a」タグを特定する。
                // Element.Text プロパティを使用して要素内のテキストを取得し、指定された文字列と比較
                if (element.Text.Contains(searchText))
                {
                    // 条件に一致する最初のエレメントが見つかったら、変数に格納しループを抜ける
                    resultElement = element;
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            // エラーハンドリングの例
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        // 定義した戻り値用の変数を返却する
        return resultElement;
    }
}
