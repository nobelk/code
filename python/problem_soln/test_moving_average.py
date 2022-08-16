import pytest

from MovingAverage import MovingAverage


def test_moving_average():
    obj = MovingAverage(3)
    assert obj.next(1) == pytest.approx(1.0)
    assert obj.next(10) == pytest.approx(5.5)
    assert obj.next(3) == pytest.approx(4.66667)
    assert obj.next(5) == pytest.approx(6.0)
