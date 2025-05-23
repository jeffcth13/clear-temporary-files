﻿# Clear Temporary Files 清理暫存檔案工具
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
如何透過工作排程(Task Scheduler)設定自動清除暫存檔，請按照以下步驟來設定。<br>
1. 首先用 ```Win+R```, 輸入```taskschd.msc```執行工作排程器。
2. 點選右側「動作」列表中的【建立基本工作】會開啟一個設定精靈。
3. 輸入工作排程名稱與描述，輸入完後點擊下一步。
4. 觸發程序為選擇觸發的時間間隔，可選擇「在您登入時執行」，將會在每次電腦開機後自動執行。下一步。
5. 工作執行動作選擇「啟動程式」。下一步。
6. 在「程式或指令碼」的欄位中，點擊【瀏覽】，找出執行檔的路徑位置後，選擇ClearTempFiles.exe。下一步。
7. 確認「摘要」中所有的設定內容無誤後，點擊完成。即設定完自定清除暫存檔的工作排程。
