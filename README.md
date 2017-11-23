
サーバー起動:

```
$ cd [このディレクトリ]/AssetBundles
$ ruby -rwebrick -e 'WEBrick::HTTPServer.new(:DocumentRoot => "./", :Port => 8000).start'
```
