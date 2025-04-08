# Clear Temporary Files 清理暫存檔案工具
這是一個用 C# 編寫的應用程式，能夠自動找出系統的暫存檔位置並刪除所有暫存檔與子目錄。
你也可以將這個程式加入到 Windows 排程中，實現自動化清理。

## 目錄
- [使用](#使用)
- [Windows排程設置](#Windows排程設置)
## 使用
請按照以下步驟來安裝和運行本應用程式
1. 克隆此倉庫到本地：
    ```sh
    git clone https://github.com/jeffcth13/clear-temporary-files.git
    ```
2. 使用 Visual Studio 編譯專案，點擊「建置專案」或使用以下命令編譯：
   ```sh
    dotnet build
   ```
   或<br>
   直接在 Viusual Studio 中，按下 `F5` 鍵運行專案，運行時也將會同時編譯專案。<br>兩種方式編譯後的執行檔即位於 `\ClearTempFiles\bin\Debug\ClearTempFiles.exe`。
4. 於 `Debug`資料夾內手動執行 ```ClearTempFiles.exe``` 執行檔。<br>
   或<br>
   使用以下命令執行：
   ```sh
   dotnet run
   ```


## Windows排程設置
