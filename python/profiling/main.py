# This is a sample Python script.

# Press ⌃R to execute it or replace it with your code.
# Press Double ⇧ to search everywhere for classes, files, tool windows, actions, and settings.
import time
#import line_profiler
#profile = line_profiler.LineProfiler()


# area of complex space to investigate
x1, x2, y1, y2 = -1.8, 1.8, -1.8, 1.8
c_real, c_imag = -0.62772, -0.42193

def calculate_z_serial_pure_python(maxiter, zs, cs):
    output = [0]*len(zs)
    for i in range(len(zs)):
        n = 0
        z=zs[i]
        c=cs[i]
        while abs(z) < 2 and n < maxiter:
            z = z * z + c
            n += 1
        output[i] = n
    return output

def calculate_julia_set_pure_python(desired_width, max_iterations):
    '''Create and list complex coordinates(zs) and complex parameters (cs),
    and build the Julia set'''
    x_step = (x2-x1)/desired_width
    y_step = (y1-y2)/desired_width
    x=[]
    y=[]
    ycoord = y2
    while ycoord > y1:
        y.append(ycoord)
        ycoord += y_step
    xcoord = x1
    while xcoord < x2:
        x.append(xcoord)
        xcoord += x_step
    zs = []
    cs = []

    for ycoord in y:
        for xcoord in x:
            zs.append(complex(xcoord, ycoord))
            cs.append(complex(c_real, c_imag))

    print("Length of x:", len(x))
    print("Total elements:", len(zs))

    start_time = time.time()
    output = calculate_z_serial_pure_python(max_iterations, zs, cs)
    end_time = time.time()
    secs = end_time - start_time
    print(calculate_z_serial_pure_python.__name__ + " took ", secs, " seconds")
    assert sum(output) == 33219980


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    calculate_julia_set_pure_python(desired_width=1000, max_iterations=300)