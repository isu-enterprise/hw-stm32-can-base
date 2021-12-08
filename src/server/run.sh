#!/bin/sh 

set -x

sudo chmod a+rw /dev/spidev0.0
. cardio/bin/activate

python api.py



