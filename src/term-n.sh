#!/bin/bash

# DELAY=150
DELAY=40
DEV=/dev/ttyUSB0
% DEV=/dev/ttyS1

picocom --imap lfcrlf -b $1 -s "./xfr.py" $DEV
# picocom --imap lfcrlf -b 115200 -s "ascii-xfr -s -l $DELAY -n" $DEV $*
# picocom --imap lfcrlf -b 9600 -s "ascii-xfr -s -l $DELAY -n" $DEV $*
