#!/bin/sh 

set -x

sudo chmod a+rw /dev/spidev0.0
sudo chmod a+rw /dev/ttypS1
. cardio/bin/activate

python api.py



