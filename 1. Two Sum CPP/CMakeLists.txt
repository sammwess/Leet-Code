cmake_minimum_required(VERSION 3.5.0)
project(1TwoSumCPP VERSION 0.1.0 LANGUAGES C CXX)

# Set C++ standard to C++11 or later
set(CMAKE_CXX_STANDARD 23)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Add Google Test as a subdirectory
add_subdirectory(googletest)

# Add your source files
add_executable(1TwoSumCPP main.cpp)
add_executable(TwoSumTest TwoSumTest.cpp)
add_executable(TwoSumV2Test TwoSumV2Test.cpp)

# Link Google Test libraries
target_link_libraries(1TwoSumCPP gtest gtest_main)
target_link_libraries(TwoSumTest gtest gtest_main)
target_link_libraries(TwoSumV2Test gtest gtest_main)

enable_testing()

add_test(NAME TwoSumTest COMMAND TwoSumTest)
add_test(NAME TwoSumV2Test COMMAND TwoSumV2Test)

include(CTest)
