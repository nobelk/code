# csv_to_parquet.py

import pandas as pd
import pyarrow as pa
import pyarrow.parquet as pq

import dask.dataframe as dd
from dask.diagnostics import ProgressBar
from matplotlib import pyplot as plt


csv_file = 'C:\\Users\\nobel\\source\\code\\python\\dask-test\\data\\yellow_tripdata_2020-01.csv'
parquet_file = 'C:\\Users\\nobel\\source\\code\\python\\dask-test\\data\\yellow_tripdata_2020-01.parquet'
parking_csv_file = 'C:\\Users\\nobel\\source\\code\\python\\dask-test\\data\\Parking_Violations_Issued_-_Fiscal_Year_2017.csv'

def dask_test():
    print("Starting dask test")
    df = dd.read_csv(
        parking_csv_file,
        low_memory=False,
        dtype={'Issuer Squad': 'object',
       'Unregistered Vehicle?': 'float64',
       'Violation Description': 'object',
       'Violation Legal Code': 'object',
       'Violation Post Code': 'object'})
    missing_values = df.isnull().sum()
    missing_count = ((missing_values/df.index.size)*100)
    missing_count
    
    with ProgressBar():
        missing_count_pct = missing_count.compute()
    
    columns_to_drop = missing_count_pct[missing_count_pct > 60].index    
    with ProgressBar():
        df_dropped = df.drop(columns_to_drop, axis=1).persist()
    
    print(missing_count_pct)

def main():
    dask_test()


# Test writing parquet files
def write_parquet_file():
    csv_file = 'C:\\Users\\nobel\\source\\code\\python\\dask-test\\yellow_tripdata_2020-01.csv'
    parquet_file = 'C:\\Users\\nobel\\source\\code\\python\\dask-test\\yellow_tripdata_2020-01.parquet'
    chunksize = 100_000
    csv_stream = pd.read_csv(csv_file, chunksize=chunksize, low_memory=False)
    for i, chunk in enumerate(csv_stream):
        print("Chunk", i)
        if i == 0:
            # Guess the schema of the CSV file from the first chunk 
            parquet_schema = pa.Table.from_pandas(df=chunk).schema
            # Open a Parquet file for writing
            parquet_writer = pq.ParquetWriter(parquet_file, parquet_schema, compression='snappy')
            # Write CSV chunk to the parquet file
            table = pa.Table.from_pandas(chunk, schema=parquet_schema)
            parquet_writer.write_table(table)
    parquet_writer.close()

if __name__ == "__main__":
    main()