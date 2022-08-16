from Logger import Logger


def test_logger():
    logger = Logger()
    assert logger.should_print_msg(1, "foo") is True
    assert logger.should_print_msg(2, "bar") is True
    assert logger.should_print_msg(3, "foo") is False
    assert logger.should_print_msg(4, "bar") is False
    assert logger.should_print_msg(10, "foo") is False
    assert logger.should_print_msg(11, "foo") is True
