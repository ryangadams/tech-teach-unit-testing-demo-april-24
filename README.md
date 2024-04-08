# Slightly adjusted Gilded Rose starting position in Python

This is an adjusted version of the Gilded Rose Kata by Emily Bache. You should look 
at the [original repository here](https://github.com/emilybache/GildedRose-Refactoring-Kata) 
as it contains starting points in multiple languages. This is only in python. 

The original implementation has a single failing test using the unittest framework
but I've switched to pytest (as the tests have a bit less boilerplate). However,
to run these tests you must install the pytest framework.

This code is being used as part of a short session on unit testing for teachers.

## Required setup
```
# create a virtual environment
python -m venv .venv

# activate it (different on Mac and Windows)
source ./venv/bin/activate # macos

.\Scripts\activate.bat # windows

# install pytest
pip install pytest
```


## Run the unit tests from the Command-Line

```
pytest
```

Unlike the actual kata, there are some implemented and passing tests here. Feel 
free to write some more. I'll update this repo with a complete set of tests 
after the second session.

## Run the TextTest fixture from the Command-Line

For e.g. 10 days:

```
python texttest_fixture.py 10
```

You should make sure the command shown above works when you execute it in a terminal before trying to use TextTest (see below).

