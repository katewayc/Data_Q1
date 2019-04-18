# 資料處理與呈現

建立一個 ASP.NET MVC 專案，將資料呈現在網頁上，並依照資料欄位格式化字串


## 基本

- UI 請用表格呈現，樣式不拘可以自己設計

- UI 欄位說明
    
    - Date -  格式化 Date1 字串 'yyyy/MM/dd HH:mm:ss'
    - ProductName - Product_Name 內容
    - Price - 依照 Locale 欄位，格式化 Price 為對應貨幣的格式字串，若無法轉換則呈現 '-'
    - PromotePrice -  依照 Locale 欄位，格式化 Promote_Price 為對應貨幣格式字串，若無法轉換則呈現 '-'

- Locale 對應地區說明

    - US - Unite State
    - DE - Germany
    - CA - Canada
    - ES - Spain
    - FR - France
    - JP - Japan
    

## 改良

- 區分 View 與 Controller 的職責
- 使用 ViewModel
