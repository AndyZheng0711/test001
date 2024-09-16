﻿using MyWebAPI.Models;

namespace MyWebAPI.Dtos
{
    public class FinancialRecordDto
    {
        public int 出表日期 { get; set; } = 0;
        public int 資料年月 { get; set; } = 0;
        public int 公司代號 { get; set; } = 0;
        public string 公司名稱 { get; set; } = "";
        public string 產業別 { get; set; } = "";
        public decimal 營業收入_當月營收 { get; set; } = 0;
        public decimal 營業收入_上月營收 { get; set; } = 0;
        public decimal 營業收入_去年當月營收 { get; set; } = 0;
        public decimal 營業收入_上月比較增減 { get; set; } = 0;
        public decimal 營業收入_去年同月增減 { get; set; } = 0;
        public decimal 累計營業收入_當月累計營收 { get; set; } = 0;
        public decimal 累計營業收入_去年累計營收 { get; set; } = 0;
        public decimal 累計營業收入_前期比較增減 { get; set; } = 0;
        public string 備註 { get; set; } = "";
    }

    public class FinancialRecordDtoList : BaseModel
    {
        public List<FinancialRecordDto> Data { get; set; } = new();
    }
}
