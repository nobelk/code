import sys
import uuid

def run():
    import concurrent.futures
    import itertools

    with concurrent.futures.ThreadPoolExecutor(max_workers=10) as executor:
        def create_filename():
            file_name = str(uuid.uuid4()).replace('-','')
            print(file_name)
            print('\n')
        futures = {executor.submit(create_filename) for _ in itertools.repeat(None, 15)}
        concurrent.futures.wait(futures) 


if __name__=='__main__':
    run()