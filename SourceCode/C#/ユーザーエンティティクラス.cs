using System;

/// <summary>
/// ユーザーを扱うエンティティクラス
/// </summary>
public class UserEntity
{
    /// <summary>
    /// ユーザー名
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// パスワード
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// UserEntityクラスの新しいインスタンスを初期化します。
    /// プロパティのデフォルト値を設定します。
    /// </summary>
    public UserEntity()
    {
        // "" は String.Empty とします。
        // 変数定義には var を使用します。
        var defaultUserName = String.Empty;
        var defaultPassword = String.Empty;

        this.UserName = defaultUserName;
        this.Password = defaultPassword;
    }
}
