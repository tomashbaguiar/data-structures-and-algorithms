cmake_minimum_required(VERSION 3.23)
project(studying)

set(CMAKE_CXX_STANDARD 14)

include_directories(src)

add_subdirectory(src)
add_subdirectory(test)
add_subdirectory(lib/google-test)