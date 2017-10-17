(* code/_data/05_08_1.fsx *)

#I "../_refs/FSharp.Data"
#r "FSharp.Data.dll"
module Data = 
    open FSharp.Data
    let DataFolder = __SOURCE_DIRECTORY__
    let DataFilePath = DataFolder + "/wb_youth_unemploy.csv"

    //CSV Dosya Kolon isimleri
    //CountryName,CountryCode,Year,Ratio

    type Unemployment = CsvProvider<Sample="wb_youth_unemploy_sample.csv",
                                    HasHeaders=true,
                                    AssumeMissingValues=true,
                                    MissingValues="",
                                    CacheRows=false>

    let LoadData() = 
        Unemployment.Load(DataFilePath).Rows |> List.ofSeq