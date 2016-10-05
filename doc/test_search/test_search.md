# テスト自動化の調査

### アクション実行結果のレスポンスコードを検証

* メソッド：

```ruby:
assert_response(type, message = nil)
```

* 説明：アクション実行結果のレスポンスコードを検証

* 例：

```ruby:
assert_response :success
```

* [参考サイト](http://railsdoc.com/test)
