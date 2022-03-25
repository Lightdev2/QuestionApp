<template>
  <div class="pagination">
    <button
      v-for="(item, idx) in pages"
      :key="idx"
      class="pagination__btn"
      @click="emitNext(item)"
      :class="{
        'pagination__btn--active': isCurrent(item),
      }"
    >
      {{ item }}
    </button>
  </div>
</template>

<script>
export default {
  name: "PaginationComponent",
};
</script>

<script setup>
import { defineProps, defineEmits, computed } from "vue";
const props = defineProps(["current", "count"]);
const emits = defineEmits(["next"]);
const isCurrent = (_num) => {
  return _num === props.current;
};
const emitNext = (_value) => {
  if (_value == "...") return;
  if (_value == "Next") {
    emits("next", props.current + 1);
    return;
  }
  if (_value == "Back") {
    emits("next", props.current - 1);
    return;
  }
  emits("next", _value);
};

const pages = computed(() => {
  let seq = [];
  if (props.current < 5) {
    seq = [1, 2, 3, 4, 5, "...", props.count, "Next"];
    if (props.current > 1) seq.unshift("Back");
    return seq;
  }
  if((props.current + 3) >= props.count || props.current === props.count) {
    seq = ['Back', 1, '...', ...range(props.count - 4, props.count)]
    if(props.current !== props.count) {
      seq.push("Next")
    }
    console.log("asd")
    return seq;
  }
  if(props.current >= 5) {
    seq = ['Back', 1];
    seq = [...seq,'...', ...range(props.current - 2, props.current + 2),'...', props.count, 'Next']
    return seq;
  }
  return seq;
});
const range = (_start, _end) => {
  const range = [];
  for(let i = _start; i <= _end; i++) {
    if (i > props.count) {
      break;
    }
    range.push(i)
  }
  return range;
}
</script>

<style scoped lang="scss">
.pagination {
  display: flex;
  &__btn {
    font-size: 13px;
    padding: 0 8px;
    line-height: 1.92307692;
    color: var(--black700);
    background: transparent;
    border: 1px solid var(--black100);
    border-radius: 3px;
    cursor: pointer;
    &:not(:last-child) {
      margin-right: 5px;
    }
    &--active {
      background: var(--orange);
      color: var(--black);
    }
  }
  &__dots {
    color: var(--black700);
    display: flex;
    align-items: center;
    justify-content: center;
    margin-right: 5px;
  }
}
</style>
