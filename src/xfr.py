#!/usr/bin/env python3

import sys

if len(sys.argv) != 2:
    sys.stderr.write(f"usage: {sys.argv[0]} FILE\n")
    sys.exit(1)

def xfr(parent_fname, parent_lineno, fname):
    lineno = 1
    try:
        for line in open(fname, "rt"):
            if line.startswith("#include "):
                xfr(fname, lineno, line[9:].strip())
            else:
                sys.stdout.write(line)
                response = sys.stdin.readline()
                sys.stderr.write(response)
                if not response.endswith("ok.\n"):
                    sys.stderr.write(f"*** {fname}({lineno}): compilation error ***")
                    sys.exit(1)
            lineno += 1
    except OSError as e:
        if parent_fname is not None:
            sys.stderr.write(f"*** {parent_fname}({parent_lineno}): {e} ***")
        else:
            sys.stderr.write(f"*** {fname}: {e} ***")
        sys.exit(1)

xfr(None, 0, sys.argv[1])

