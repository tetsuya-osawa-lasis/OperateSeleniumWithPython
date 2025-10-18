
### 【Python Selenium（初心者向け）】PythonのインストールからWebサイトへのアクセスまで含めた簡単なスクレイピングを行うための一通りの手順
### https://kuku81kuku81.hatenablog.com/entry/2023/03/11_python_selenium_how_to_download_install_access_website#%EF%BC%91Python%E3%81%AE%E3%83%80%E3%82%A6%E3%83%B3%E3%83%AD%E3%83%BC%E3%83%89%E3%81%A8%E3%82%A4%E3%83%B3%E3%82%B9%E3%83%88%E3%83%BC%E3%83%AB

### ↓ライブラリインポート

import os

from selenium import webdriver
from selenium.webdriver.chrome import service as fs
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys

### ↑ライブラリインポート



# EdgeDriverのパス
_filePath_MsEdgeDriverExe: str = os.getcwd() + "\\msedgedriver.exe"

# ドライバー指定でEdgeブラウザを開く
_msEdgeDriberService = fs.Service(executable_path = _filePath_MsEdgeDriverExe)

_driver: webdriver = webdriver.Edge(service = _msEdgeDriberService)

_url: str = "https://www.google.com/"

_driver.get(_url)

#検索ボックス（nameが"q"）を探索
_webElement = _driver.find_element(By.NAME, "q")

#検索テキストボックスに"abc"を入力
_webElement.send_keys("abc")
_webElement.send_keys(Keys.ENTER)