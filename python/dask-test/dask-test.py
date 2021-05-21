# csv_to_parquet.py

import pandas as pd
import pyarrow as pa
import pyarrow.parquet as pq

import dask.dataframe as dd
from dask.diagnostics import ProgressBar


csv_file = 'C:\\Users\\nobel\\source\\code\\python\\dask-test\\yellow_tripdata_2020-01.csv'
parquet_file = 'C:\\Users\\nobel\\source\\code\\python\\dask-test\\yellow_tripdata_2020-01.parquet'

def main():
    print("Starting dask test")
    df = dd.read_parquet(parquet_file)



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