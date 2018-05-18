# -*- coding: utf-8 -*-

from EncodeECC import encode
from EncodeECC import decode
import EccMath
# import Eccc

def encryptECC(m, P):

    M = encode(m)
    C2 = EccMath.add_Points(M, P)
    return C2


def decryptECC(C, C2):

    M = EccMath.add_Points(C2, C)
    m = decode(M)

    return m
