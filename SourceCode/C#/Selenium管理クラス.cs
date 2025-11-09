using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// セレニウム（Selenium）操作を提供する管理クラス
/// </summary>
public class SeleniumManager
{
    // プロパティは設計に記載されていないため、省略します。

    /// <summary>
    /// HTMLの「a」タグの中から、指定された文字列を含む最初のエレメントを取得します。
    /// </summary>
    /// <param name="webDriver">SeleniumのWebドライバ</param>
    /// <param name="searchText">指定された文字列</param>
    /// <returns>エレメント（Seleniumのエレメント）</returns>
    public IWebElement GetFirstAnchorElementWithText(IWebDriver webDriver, string searchText)
    {
        // 戻り値用の変数を定義し、デフォルト値として初期化します。
        var resultElement = (IWebElement)null;

        // 引数のnullチェックなど、堅牢性を高めるための処理を適宜追加できます。
        if (webDriver == null)
        {
            Console.WriteLine("Webドライバがnullです。");
            return resultElement;
        }

        // "" は String.Empty とします。
        if (searchText == null)
        {
            var emptySearchText = String.Empty;
            searchText = emptySearchText;
        }

        try
        {
            // HTMLに含まれる、すべての「a」タグを取得する。（LIST型）
            // var を使用して変数を定義します。
            var anchorElements = webDriver.FindElements(By.TagName("a"));

            // 上記の「a」タグのリストに対して、ループ処理を行う。
            foreach (var element in anchorElements)
            {
                // ループ処理の中で、「a」タグの配下に、引数で渡された「指定された文字列」が含まれる「a」タグを特定する。
                // エレメントのテキストコンテンツが指定された文字列を含んでいるか確認します。
                if (element.Text.Contains(searchText))
                {
                    resultElement = element;
                    // 最初に見つかった時点でループを抜けます。
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            // エラーハンドリングの例
            Console.WriteLine($"エラーが発生しました: {ex.Message}");
            // エラーが発生した場合も、デフォルト値の resultElement (null) が返却されます。
        }

        // 戻り値用の変数を返却します。
        return resultElement;
    }
}
