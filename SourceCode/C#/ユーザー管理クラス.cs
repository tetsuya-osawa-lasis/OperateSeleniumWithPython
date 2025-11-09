using System;
using System.Collections.Generic;

/// <summary>
/// ユーザーを管理するクラス
/// </summary>
public class UserManager
{
    /// <summary>
    /// ユーザーエンティティのリスト
    /// </summary>
    public List<UserEntity> UserEntities { get; set; }

    /// <summary>
    /// UserManagerクラスの新しいインスタンスを初期化します。
    /// </summary>
    public UserManager()
    {
        // 変数定義には var を使用します。
        // リストのデフォルト値として、新しい空のリストを初期化します。
        var defaultUserList = new List<UserEntity>();

        this.UserEntities = defaultUserList;
    }
}
