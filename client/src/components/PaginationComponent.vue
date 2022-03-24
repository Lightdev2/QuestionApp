<template>
  <div class="pagination">
    <button class="pagination__btn" v-if="current > 1" @click="emitNext(props.current - 1)">Back</button>
    <button
      class="pagination__btn"
      @click="emitNext(1)"
      :class="{
        'pagination__btn--active': isCurrent(1),
      }"
    >
      1
    </button>
    <div v-if="current >= 5" class="pagination__dots">...</div>
    <template v-if="current < 5">
      <button
        @click="emitNext(i)"
        class="pagination__btn"
        :class="{
          'pagination__btn--active': isCurrent(i),
        }"
        v-for="i in [2, 3, 4, 5]"
        :key="i"
      >
        {{ i }}
      </button>
    </template>
    
    <template v-else-if="current + 5 <= count">
      <button
        @click="emitNext(i)"
        class="pagination__btn"
        :class="{
          'pagination__btn--active': isCurrent(i),
        }"
        v-for="i in range(current - 2, current + 2)"
        :key="i"
      >
        {{ i }}
      </button>
    </template>
    <div v-if="current >= 5" class="pagination__dots">...</div>
    <button class="pagination__btn" v-if="current !== props.count" @click="emitNext(props.current + 1)">Next</button>
    <button
      @click="emitNext(props.count)"
      class="pagination__btn"
      :class="{
        'pagination__btn--active': isCurrent(0),
      }"
    >
      {{ props.count }}
    </button>
  </div>
</template>

<script>
export default {
  name: "PaginationComponent",
};
</script>

<script setup>
import { defineProps, defineEmits} from "vue";
const props = defineProps(["current", "count"]);
const emits = defineEmits(["next"])
const isCurrent = (_num) => {
  return _num === props.current;
};
const emitNext = (_value) => {
  emits("next", _value)
}
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
    justify-content:center;
    margin-right: 5px;
  }
}
</style>
